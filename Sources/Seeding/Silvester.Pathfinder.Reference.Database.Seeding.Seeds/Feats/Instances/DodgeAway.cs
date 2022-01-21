using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DodgeAway : Template
    {
        public static readonly Guid ID = Guid.Parse("56725762-0fac-4ad9-b4a8-b7a0d3eaca6e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dodge Away",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You are the target of a melee attack.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1da4f1e9-bba5-422f-bc81-aaa17fb34387"), Type = TextBlockType.Text, Text = $"You use your acrobatic prowess to evade an attack, using momentum to keep yourself moving, if you choose. You gain a +1 circumstance bonus to AC against the triggering attack. If the attack misses you, you can {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)} after the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. If you're a master in Acrobatics, you can move 10 feet on this {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)} instead of 5 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("228cae84-0840-454c-98b5-71b1e44d9612"), Feats.Instances.AcrobatDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("00e5f9f3-6b95-455a-8752-f63c73478105"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
