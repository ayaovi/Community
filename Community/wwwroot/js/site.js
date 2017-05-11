// Write your Javascript code.


var blocks = [
 {
   x: 12, y: 23, w: 20, h: 14, c: "#CC6600"
 },
 {
   x: 112, y: 123, w: 20, h: 14, c: "#CC9900"
 }
];



function setup() {
  createCanvas(600, 400);
  console.log("hey there");
}

var lastRefreshTimeMs = 0;

function draw() {
  var now = millis();
  if((now - lastRefreshTimeMs) > 100)
  {
    refreshData();
    lastRefreshTimeMs = now;
  }


  background(150);
  blocks.forEach(b =>{
    fill(color(b.c));
    rect(b.x, b.y, b.w, b.w);
  });
}

function refreshData() {
  num = 10000;
  httpGet('Blocks?num='+ num, 'json', success => { 
    console.log('refreshed data');
    blocks = success;
  }, error => { 
    console.log(error);
  })
}