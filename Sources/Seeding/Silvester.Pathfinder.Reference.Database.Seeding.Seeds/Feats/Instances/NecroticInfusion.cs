using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NecroticInfusion : Template
    {
        public static readonly Guid ID = Guid.Parse("7068f682-a9c9-4915-8f25-44c136631d2e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Necrotic Infusion",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2e885047-4b35-4bac-8710-aaa474773193"), Type = TextBlockType.Text, Text = $"You pour negative energy into your undead subject to empower its attacks. If the next action you use is to cast {ToMarkdownLink<Models.Entities.Spell>("harm", Spells.Instances.Harm.ID)} to restore Hit Points to a single undead creature, the target then deals an additional 1d6 negative damage with its melee weapons and unarmed attacks until the end of its next turn." };
            yield return new TextBlock { Id = Guid.Parse("9949d99c-ff2c-442b-8b6f-56537290e58d"), Type = TextBlockType.Text, Text = $"If the {ToMarkdownLink<Models.Entities.Spell>("harm", Spells.Instances.Harm.ID)} spell is at least 5th level, this damage increases to 2d6, and if the {ToMarkdownLink<Models.Entities.Spell>("harm", Spells.Instances.Harm.ID)} spell is at least 8th level, the damage increases to 3d6." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineFont(Guid.Parse("11db9fef-88e7-4ebd-aa5f-f7860f9d638d"), DivineFonts.Instances.Harm.ID);
            builder.AddOr(Guid.Parse("10713e9a-9cb4-4b7e-80d5-c898f59a14fc"), or => 
            {
                or.HaveSpecificAlignment(Guid.Parse("447f2a30-9c11-4b03-8036-5941e374238e"), Alignments.Instances.LawfulEvil.ID);
                or.HaveSpecificAlignment(Guid.Parse("83d9d967-1ee3-420a-8cb0-fc29321d7ac4"), Alignments.Instances.ChaoticEvil.ID);
                or.HaveSpecificAlignment(Guid.Parse("9c2756f0-7038-400d-8171-a280b06b3c4d"), Alignments.Instances.NeutralEvil.ID);
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
                Id = Guid.Parse("c382ce81-58f4-4ca4-9d39-1b6a26b03901"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
