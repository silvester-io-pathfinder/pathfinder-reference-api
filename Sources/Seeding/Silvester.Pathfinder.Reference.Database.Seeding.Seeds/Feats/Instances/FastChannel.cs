using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FastChannel : Template
    {
        public static readonly Guid ID = Guid.Parse("a1da756b-df93-4b0b-9a96-9e6800248a85");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fast Channel",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("284acb99-ca5b-41ab-8d20-5021e4bb098a"), Type = TextBlockType.Text, Text = $"Divine power is always at your fingertips, swiftly responding to your call. When you cast {ToMarkdownLink<Models.Entities.Spell>("harm", Spells.Instances.Harm.ID)} or {ToMarkdownLink<Models.Entities.Spell>("heal", Spells.Instances.Heal.ID)} by spending 2 actions, you can get the effects of the 3-action version instead of the 2-action version." };
            yield return new TextBlock { Id = Guid.Parse("65ffb1cc-4163-4e0a-956d-b2645d0d41c6"), Type = TextBlockType.Text, Text = $"You can do this with {ToMarkdownLink<Models.Entities.Spell>("harm", Spells.Instances.Harm.ID)} if you have harmful font or {ToMarkdownLink<Models.Entities.Spell>("heal", Spells.Instances.Heal.ID)} if you have healing font (or both if you have {ToMarkdownLink<Models.Entities.Feat>("Versatile Font", Feats.Instances.VersatileFont.ID)})." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("eb55b342-4a49-4c57-a53b-d00da10729bd"), or => 
            {
                or.HaveSpecificDivineFont(Guid.Parse("921ac2b3-6dc6-4a54-8bc0-463c83f9d810"), DivineFonts.Instances.Heal.ID);
                or.HaveSpecificDivineFont(Guid.Parse("88c74aa6-f231-40b7-8e39-da9867e16ca8"), DivineFonts.Instances.Harm.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6aae3cef-f2dc-4cdc-a064-2ece1c8652de"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
