const axios = require('axios');
const fs = require('fs');

console.log('Getting the magic number for release info...');

const magic = fs.readFileSync('../7-Presentation/magic-number.txt');
console.log(`The magic number is: ${magic}`);

const url = `https://hook.integromat.com/2zabcvfrefsnlkr0dypo5vvojij7mr6o?magic=${magic}`
console.log('Triggering release webhook...');

axios.get(url)
  .then(function (response) {
    console.log('Successfully triggerd release webhook!');
  })
  .catch(function (error) {
    throw new Error(error.message);
  })
