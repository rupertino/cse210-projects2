using System.Collections.Generic;
using Unit05.Game.Casting;
using Unit05.Game.Services;


namespace Unit05.Game.Scripting
{
    /// <summary>
    /// <para>An output action that draws all the actors.</para>
    /// <para>The responsibility of DrawActorsAction is to draw each of the actors.</para>
    /// </summary>
    public class DrawActorsAction : Action
    {
        private VideoService videoService;

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public DrawActorsAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        /// <inheritdoc/>
        public override void Execute(Cast cast, Script script)
        {
            CycleOne cycleone = (CycleOne)cast.GetFirstActor("cycleone");
            List<Actor> segments1 = cycleone.GetSegments();
            CycleTwo cycletwo = (CycleTwo)cast.GetFirstActor("cycletwo");
            List<Actor> segments2 = cycletwo.GetSegments();
            Actor onescore = cast.GetFirstActor("onescore");
            Actor twoscore = cast.GetFirstActor("twoscore");
            onescore.SetPosition(new Point(Constants.MAX_X -850, 0));
            twoscore.SetPosition(new Point(Constants.MAX_X -150, 0));
            List<Actor> messages = cast.GetActors("messages");
            
            videoService.ClearBuffer();
            videoService.DrawActors(segments1);
            videoService.DrawActors(segments2);
            videoService.DrawActor(onescore);
            videoService.DrawActor(twoscore);
            videoService.DrawActors(messages);
            videoService.FlushBuffer();
        }
    }
}