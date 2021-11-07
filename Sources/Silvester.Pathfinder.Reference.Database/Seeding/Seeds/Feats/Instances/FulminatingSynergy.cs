using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FulminatingSynergy : Template
    {
        public static readonly Guid ID = Guid.Parse("0a67438f-d81a-44aa-862d-01b310e7084e");

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
            yield return new TextBlock { Id = Guid.Parse("6a7089a8-48f8-4acf-8ac7-a211cc71254b"), Type = TextBlockType.Text, Text = "When you draw upon your spells’ synergy, you create a physical manifestation of their magical resonance and invoke it to harm a foe. When you use (feat: Dualistic Synergy), choose a damage type: acid, cold, electricity, or fire. In addition to (feat: Dualistic Synergy)’s normal effect, a foe within 30 feet of you takes an amount of damage of the chosen type equal to the spell’s level. If the spell already deals damage of the chosen type, combine the damage before applying weaknesses and resistances." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fedb6bb6-244e-48d7-b13a-7ce71c1a966b"), Feats.Instances.DualisticSynergy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("90e93abd-5165-4bc2-b9fd-a16767ef3bce"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
