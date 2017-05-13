/**
 * @file: site.js
 * 
 * @description: 
 * 
 * @author: A.E. Djissenou
 * 
 * @version: 
 */

var blocks = [];
var cityBlocks = [];
var persons = [];


function setup() {
    createCanvas(600, 400);
    retrieveCityBlocks();
    retrievePersons();
}

var lastRefreshTimeMs = 0;

function draw() {
    // var now = millis();
    // if ((now - lastRefreshTimeMs) > 100) {
    //     refreshData();
    //     lastRefreshTimeMs = now;
    // }

    background(150);

    // blocks.forEach(b => {
    //     fill(color(b.c));
    //     rect(b.x, b.y, b.w, b.w);
    // });

    // stroke(255);
    fill(0);

    cityBlocks.forEach(cityBlock => {
        beginShape();
        cityBlock.forEach(location => {
            // console.log("Got here");
            vertex(location.x, location.y);
        });
        endShape(CLOSE);
    });


    persons.forEach(person => {
        fill(person.colour);
        ellipse(person.position.x, person.position.y, 10, 10);
    });
}

function refreshData() {
    num = 10000;
    httpGet('Blocks?num=' + num, 'json', success => {
        console.log('refreshed data');
        blocks = success;
    }, error => {
        console.log(error);
    });
}

function retrieveCityBlocks() {
    httpGet('CityBlocks', 'json', success => {
        console.log('refreshed data');
        cityBlocks = success;
    }, error => {
        console.log(error);
    });
}


function retrievePersons() {
    httpGet('Persons', 'json', success => {
        console.log('refreshed data');
        persons = success;
    }, error => {
        console.log(error);
    });
}