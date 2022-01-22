using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class JudgmentOfTheMonolith : Template
    {
        public static readonly Guid ID = Guid.Parse("96e54bf9-1759-4d81-887e-47ea8fe21e73");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Judgment of the Monolith",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7513979d-5d3d-4d69-b45f-ffaff6725135"), Type = TextBlockType.Text, Text = $"You can use the oaths bound in your ka stone to compel the truth from the living and the dead. You can activate your ka stone to target a single living creature, causing that creature to experience the effects of being in a {ToMarkdownLink<Models.Entities.Spell>("zone of truth", Spells.Instances.ZoneOfTruth.ID)}. You can also activate it with a 10-minute activation (envision) to cast {ToMarkdownLink<Models.Entities.Spell>("talking corpse", Spells.Instances.TalkingCorpse.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("93ab5c91-258e-463e-9641-77f9aa532e62"), Feats.Instances.KaStoneRitual.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7683d03b-49d2-40b8-a6e5-1c2d141b7ba7"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
