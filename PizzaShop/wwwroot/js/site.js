// Create new instance of Vue
const vm = new Vue({
    el: '#app',
    data: {
        isDisplayingCheckout: false,
        selectedSize: "",
        selectedSizeImage: "", 
        selectedQuantity: 1,
        selectedToppings: [],
        stringToppings: "",
        pizzaSizeCost: 0,
        isDelivery: false
    },
    computed: {
        // dynamically change the display for the total cost of the pizza
        calculateTotalCost() {
            if (this.isDelivery == false) {
                return this.pizzaSizeCost * this.selectedQuantity;
            } else {
                return (this.pizzaSizeCost * this.selectedQuantity) + 100;
            }
            
        },
        getToppings () {
            stringToppings = this.selectedToppings.toString();
            return this.selectedToppings.toString();
        }
    },
    mounted: () => {
        const stripe = Stripe('pk_test_RrcL23bELs33G2bagBoGl55000W1Bosdhm');
        const elements = stripe.elements();

        // custom styling for elements card form
        const style = {
            base: {
                color: '#32325d',
                lineHeight: '18px',
                fontFamily: '"Helvetica Neue", Helvetica, sans-serif',
                fontSmoothing: 'antialiased',
                fontSize: '16px',
                '::placeholder': {
                    color: '#aab7c4'
                }
            },
            invalid: {
                color: '#fa755a',
                iconColor: '#fa755a'
            }
        };

        // instantiate card element
        const card = elements.create('card', { style: style });
        // add instance of the card element to the specified div
        card.mount('#card-element');

        // Handle validation errors for the card element
        card.addEventListener('change', function (event) {
            var displayError = document.getElementById('card-errors');
            if (event.error) {
                displayError.textContent = event.error.message;
            } else {
                displayError.textContent = '';
            }
        });

        // Handle form submission
        var form = document.getElementById('payment-form');
        form.addEventListener('submit', function (event) {
            event.preventDefault();

            stripe.createToken(card).then(function (result) {
                if (result.error) {
                    console.log(result.error);
                    // Inform the user if there was an error
                    var errorElement = document.getElementById('card-errors');
                    errorElement.textContent = result.error.message;
                } else {
                    // Send the token to your server
                    stripeTokenHandler(result.token);
                }
            });
        });

        // Submit the form with the token ID.
        function stripeTokenHandler(token) {
            // Insert the token ID into the form so it gets submitted to the server
            var form = document.getElementById('payment-form');
            var hiddenInput = document.createElement('input');
            hiddenInput.setAttribute('type', 'hidden');
            hiddenInput.setAttribute('name', 'token');
            hiddenInput.setAttribute('value', token.id);
            form.appendChild(hiddenInput);

            // Submit the form
            form.submit();
        }
    },
    filters: {
        currency(value) {
            return "$" + value / 100;
        }
    },
    methods: {
        // change the value of pizzaSizeCost based on the selected option in the 
        // pizzaSize select tag
        changeSelectedSize: function (event) {
            // assign selectedSize based on the selected option 
            this.selectedSize = event.target.value;
            switch (event.target.value) {
                case "small":
                    this.pizzaSizeCost = 745;
                    this.selectedSizeImage = "images/small.png"
                    break;
                case "medium":
                    this.pizzaSizeCost = 1045;
                    this.selectedSizeImage = "images/medium.png"
                    break;
                case "large":
                    this.pizzaSizeCost = 1345;
                    this.selectedSizeImage = "images/large.png"
                    break;
                default:
                    pizzaSizeCost = 0
            }
        }
    }
});