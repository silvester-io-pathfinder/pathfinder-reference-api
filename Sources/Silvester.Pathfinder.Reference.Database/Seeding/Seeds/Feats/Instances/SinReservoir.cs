using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SinReservoir : Template
    {
        public static readonly Guid ID = Guid.Parse("59c0d5ab-4f94-4099-8b7a-0e6beaaa4e5d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sin Reservoir",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5e03e914-6225-470a-bf88-c6430357bea8"), Type = TextBlockType.Text, Text = "During daily preparations, you can indulge in your associated sin. When you do, you gain one additional spell slot of any spell level up to two levels below the highest-level wizard spell you can cast. You can prepare only a spell of your specialized school in this slot. As with any other act, indulging in your sin might change your alignment if your behavior harms someone else." };
            yield return new TextBlock { Id = Guid.Parse("5157eb16-22cf-4af5-b925-da216c926cf2"), Type = TextBlockType.Text, Text = "__Add this additional spell slot manually__" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("50e2e4d2-7d1e-4366-9168-7960ceee146e"), Feats.Instances.RunelordDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6c1710e-d1b9-4ba3-8f56-5bf1c16944b8"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
