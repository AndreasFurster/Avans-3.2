const axios = require('axios');
const url = 'https://hook.integromat.com/2zabcvfrefsnlkr0dypo5vvojij7mr6o'


axios.get(url)
  .then(function (response) {
    console.log(response);
  })
  .catch(function (error) {
    console.log(error);
  })
