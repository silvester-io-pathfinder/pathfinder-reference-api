using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FulminatingSynergy : Template
    {
        public static readonly Guid ID = Guid.Parse("b5062ca9-b6d6-4d2e-a097-74ae2d2e7294");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fulminating Synergy",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ba21016e-1f1a-4cec-953a-4940aacbcaee"), Type = TextBlockType.Text, Text = "When you draw upon your spells’ synergy, you create a physical manifestation of their magical resonance and invoke it to harm a foe. When you use (feat: Dualistic Synergy), choose a damage type: acid, cold, electricity, or fire. In addition to (feat: Dualistic Synergy)’s normal effect, a foe within 30 feet of you takes an amount of damage of the chosen type equal to the spell’s level. If the spell already deals damage of the chosen type, combine the damage before applying weaknesses and resistances." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f502c439-21cf-4c7e-a248-7dcffca91f7b"), Feats.Instances.DualisticSynergy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c81239ac-8074-4e36-9bd5-cbef99550a29"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
