
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
    }


    public class ColorComponent : Component{
        public Color objectColor;

    }
    public class PlayerControlled : Component{
        bool pc;

    }
}