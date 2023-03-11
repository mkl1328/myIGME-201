/**
 * @author Max Lama
 */
class Icon {
  /**
   * 
   * @param {} typeDef 
   */
  constructor(typeDef) {
    this.pos = new createVector(0, 0);
    this.states = ["welcome", "selected", "unselected"];
    this.scale = new createVector(100,100);
    this.type = typeDef || "circle"
  }

  display() {
    switch(this.type) {
      case "square" :
        break;
    }
  }

}