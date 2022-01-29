using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TwistHealing : Template
    {
        public static readonly Guid ID = Guid.Parse("0384de12-c234-49a5-9e07-191ee81e0cf1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Twist Healing",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d1b5478b-07dd-4da3-b5d6-bef6d71cb410"), Type = TextBlockType.Text, Text = $"Your connection to both life and undeath lets you twist the healing power of magic items to suit your own needs and aims. Whenever you activate an item to cast a {ToMarkdownLink<Models.Entities.Spell>("heal", Spells.Instances.Heal.ID)} spell, you can invert its energy to produce the effects of an equivalent {ToMarkdownLink<Models.Entities.Spell>("harm", Spells.Instances.Harm.ID)} spell instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineFont(Guid.Parse("4fb790e3-a0ff-4f07-b1f2-23feb84bf6bc"), DivineFonts.Instances.Harm.ID);
            builder.HaveSpecificDivineFont(Guid.Parse("b09eb53c-b6bd-487f-a067-9864d3c2f75b"), DivineFonts.Instances.Heal.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6ee35014-67ef-4e36-a023-155a357a9762"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
