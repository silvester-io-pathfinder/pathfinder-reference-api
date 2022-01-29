using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DrawWardingCircle : Template
    {
        public static readonly Guid ID = Guid.Parse("e5121d3c-33c0-42d8-b5e3-718e44d94691");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Draw Warding Circle",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("af492f3a-de9b-4dc1-860c-94c05c9fbc62"), Type = TextBlockType.Text, Text = $"The circle is the simplest way to define a closed space, and by drawing a circle out of materials that resonate with a given creature, you define a space that prevents its entry—or escape. You spend 1 minute constructing a circle along the edges of a 10-foot burst, using materials you identified in the process of figuring out the creature's weaknesses, such as salt to keep out a ghost or anointed silver to contain a devil. Anyone except the chosen creature can cross the circle without trouble, but the chosen creature must attempt a Will save against your class DC whenever it attempts to do so. On a failure, the chosen creature remains on the same side of the circle and the action it was using to attempt to cross the circle is disrupted. Creatures other than the chosen creature can spend a total of three {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} actions scuffing the circle to break the effect early. These actions don't need to be consecutive." };
            yield return new TextBlock { Id = Guid.Parse("24220cc6-5e2b-472b-89d6-f0463fe9dce1"), Type = TextBlockType.Text, Text = $"Because of the amount of time it takes, typically you construct a circle in advance after Investigating a specific creature. A circle remains effective until you either Draw another Warding Circle or your {ToMarkdownLink<Models.Entities.Feat>("Esoteric Antithesis", Feats.Instances.EsotericAntithesis.ID)} ends (typically until you use {ToMarkdownLink<Models.Entities.Feat>("Find Flaws", Feats.Instances.FindFlaws.ID)} on another creature)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7b96068e-919f-4234-9ec4-a93b578d5a55"), Feats.Instances.EsotericAntithesis.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5a243f86-a293-4dae-8755-dac56384f82e"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
