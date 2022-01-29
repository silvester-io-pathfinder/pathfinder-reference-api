using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MakeshiftStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("ef750a77-67c1-464b-a2c0-35baf91bceb6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Makeshift Strike",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("576c35ed-59f5-47ac-b5f2-817cd3bf79f1"), Type = TextBlockType.Text, Text = $"You quickly snatch up whatever's nearby and then attack with it as an improvised weapon. You {ToMarkdownLink<Models.Entities.Action>("Interact", Actions.Instances.Interact.ID)} to pick up a nearby object you could use as an improvised weapon. It must be located at around your chest level, such as a mug on a table, rather than an object on the floor. You then either {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} or make an {ToMarkdownLink<Models.Entities.Feat>("Improvised Pummel", Feats.Instances.ImprovisedPummel.ID)} with the improvised weapon." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2765ae22-ac1c-446f-887c-04e80b3065c8"), Feats.Instances.WeaponImproviserDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d434552e-b912-4a47-a227-8100cd5c8926"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
