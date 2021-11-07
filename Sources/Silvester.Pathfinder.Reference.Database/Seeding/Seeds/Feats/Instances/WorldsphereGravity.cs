using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WorldsphereGravity : Template
    {
        public static readonly Guid ID = Guid.Parse("5286ba8d-094d-4600-acb8-5509a4ed1069");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Worldsphere Gravity",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("087cb21e-5d68-4e3f-9d7c-66fba6dcf9da"), Type = TextBlockType.Text, Text = "Though creating demiplanes usually requires lengthy rituals, you know how to establish minor planar effects in imitation of Syndara&#39;s masterpieces. If your next action is to Cast a Spell of at least 5th level from your spell slots that affects an area, you can apply one of the following planar effects to a 20-foot burst centered within the spell&#39;s area. The effect persists for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("3c857691-f293-421f-bf5d-8929f52665d6"), Type = TextBlockType.Enumeration, Text = " : **Gravitational Morass** The pull of gravity is amplified here, creating greater difficult terrain. Flying creatures that pass through the area must succeed at a Reflex save against your spell DC or fall to the ground, taking bludgeoning damage equal to half the distance fallen." };
            yield return new TextBlock { Id = Guid.Parse("b13021f2-42b9-49f0-9ba5-09a65552d9df"), Type = TextBlockType.Enumeration, Text = " : **Flowing Time** Erratic timestreams aid you within this space. A creature that starts its turn in the burst is affected by (spell: haste) on that turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1411cb26-c712-447d-8cad-b1b9afa3a6d7"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
