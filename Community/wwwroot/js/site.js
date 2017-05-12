/**
 * @file: site.js
 * 
 * @description: 
 * 
 * @author: A.E. Djissenou
 * 
 * @version: 
 */

var blocks = [{
        x: 12,
        y: 23,
        w: 20,
        h: 14,
        c: "#CC6600"
    },
    {
        x: 112,
        y: 123,
        w: 20,
        h: 14,
        c: "#CC9900"
    }
];

var cityBlocks = [
    [{
            x: 0,
            y: 0
        },
        {
            x: 124,
            y: 0
        },
        {
            x: 163,
            y: 73
        },
        {
            x: 82,
            y: 73
        },
        {
            x: 82,
            y: 117
        },
        {
            X: 0,
            Y: 117
        }
    ]
];


function setup() {
    createCanvas(600, 400);
    retrieveCityBlocks();
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

    // beginShape();
    // vertex(0, 0);
    // vertex(124, 0);
    // vertex(163, 73);
    // vertex(82, 73);
    // vertex(82, 117);
    // vertex(0, 117);
    // endShape(CLOSE);

    cityBlocks.forEach(cityBlock => {
        beginShape();
        cityBlock.forEach(location => {
            // console.log("Got here");
            vertex(location.x, location.y);
        });
        endShape(CLOSE);
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