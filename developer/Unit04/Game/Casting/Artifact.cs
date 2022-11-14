using System.Collections.Generic;
using System.IO;
using System;

namespace Unit04.Game.Casting
{

        /// <summary>
        /// <para>An item that inherits the Actor elements.</para>
        /// <para>
        /// The responsibility of an Artifact is to provide a score about itself.
        /// </para>
        /// </summary>
        public class Artifact:Actor{
            private int score = 0;

    
    // 2) Create the class constructor. Use the following method comment.
        
        /// <summary>
        /// Constructs a new instance of Artifact.
        /// </summary>
            public Artifact(){
            }
       
    // 3) Create the GetScore() method. Use the following method comment.
        
        /// <summary>
        /// Gets the artifact's score.
        /// </summary>
        /// <returns>The message as an integer.</returns>
            public int GetScore(){
                
                return score;

            }

    // 4) Create the SetScore(int score) method. Use the following method comment.
        
        /// <summary>
        /// Sets the ScoreBoard score to the given value.
        /// </summary>
        /// <param name="score">The given score.</param>
            public void SetScore(int score){
                this.score = score;

            }
        }
}