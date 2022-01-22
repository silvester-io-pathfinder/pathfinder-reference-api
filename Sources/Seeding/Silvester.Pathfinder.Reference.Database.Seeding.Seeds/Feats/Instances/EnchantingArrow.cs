using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnchantingArrow : Template
    {
        public static readonly Guid ID = Guid.Parse("a79e26ff-0966-40b5-8b32-a6f675aabe48");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Enchanting Arrow",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("214ad469-54b7-4812-bb9f-b94b064b3beb"), Type = TextBlockType.Text, Text = $"With a single whisper carried on the wind, you enchant your ammunition to make a foe more vulnerable to your attacks. Make a bow {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. On a hit, the target takes an additional 2d6 mental damage. On a critical hit, the target also becomes stunned 1. The mental damage increases to 3d6 if your bow has a {ToMarkdownLink<Models.Items.Instances.FundamentalWeaponRune>("greater striking rune", Items.FundamentalWeaponRunes.Instances.Striking.ID)}, or to 4d6 if your bow has a {ToMarkdownLink<Models.Items.Instances.FundamentalWeaponRune>("major striking rune", Items.FundamentalWeaponRunes.Instances.Striking.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5a9dc9a1-2e07-485c-96fa-e909afd2a82d"), Feats.Instances.EldritchArcherDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b4a86525-452d-4e60-9999-2d9e61fd464f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
