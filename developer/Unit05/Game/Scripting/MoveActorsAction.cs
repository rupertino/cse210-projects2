using System.Collections.Generic;
using Unit05.Game.Casting;


namespace Unit05.Game.Scripting
{
    // TODO: Implement the MoveActorsAction class here

    // 1) Add the class declaration. Use the following class comment. Make sure you
    //    inherit from the Action class.

    /// <summary>
    /// <para>An update action that moves all the actors.</para>
    /// <para>
    /// The responsibility of MoveActorsAction is to move all the actors.
    /// </para>
    /// </summary>
    public class MoveActorsAction : Action
    {

    
    // 2) Create the class constructor. Use the following method comment.

    /// <summary>
    /// Constructs a new instance of MoveActorsAction.
    /// </summary>
        public MoveActorsAction(){

        }

    // 3) Override the Execute(Cast cast, Script script) method. 
        public override void Execute(Cast cast, Script script){
            List<Actor> actors = cast.GetAllActors();
            foreach(Actor actor in actors){
                actor.MoveNext();
            }
        }
    }
}