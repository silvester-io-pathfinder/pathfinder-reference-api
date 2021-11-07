using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnergeticResonance : Template
    {
        public static readonly Guid ID = Guid.Parse("68538777-2f40-4898-8e0a-06db215b95c8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Energetic Resonance",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You would take acid, cold, electricity, fire, or sonic damage from a spell.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("db0f3ce2-8349-4d58-a121-67ffd11b492e"), Type = TextBlockType.Text, Text = "Your body resonates with magical energy, mitigating the effects of harmful spells. Expend one of your spell slots of a level equal to or higher than that of the triggering spell. You gain resistance to one of the triggering effect’s damage types equal to twice the expended spell slot’s level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("56361059-cfbc-4c2f-a813-bb78d0b86da7"), Feats.Instances.WellspringMageDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("27de206b-3ee3-4a99-9761-e6ea3573111d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
