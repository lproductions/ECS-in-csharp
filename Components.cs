
using SFML.Graphics;
//Components to use in ECS. These are usually inside the entities and hold all of the data.
namespace ECS {

    public class Component{

    }

    public class Health : Component{
        public int hp;

        public Health(int HP){
            hp = HP;
        }
        
    }

    public class Position : Component{
        public int x;
        public int y;

        public Position(int inputx, int inputy){
            x = inputx;
            y = inputy;
        }
    }


    public class ColorComponent : Component{
        public Color objectColor;

        public ColorComponent(Color col){
            objectColor = col;
        }

    }

    // doesn't need any values yet. just by having a player controlled component shows
    // that its player controlled. no need for bool.
    public class PlayerControlled : Component{
        

        public PlayerControlled(){

        }

    }
}