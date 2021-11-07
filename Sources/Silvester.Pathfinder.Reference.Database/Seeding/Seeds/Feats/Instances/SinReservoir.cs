using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SinReservoir : Template
    {
        public static readonly Guid ID = Guid.Parse("4fdf233f-f5d4-43f9-ab8c-3caf970cfbbb");

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
            yield return new TextBlock { Id = Guid.Parse("c59bd17f-27c5-45f7-840a-5a002891af9f"), Type = TextBlockType.Text, Text = "During daily preparations, you can indulge in your associated sin. When you do, you gain one additional spell slot of any spell level up to two levels below the highest-level wizard spell you can cast. You can prepare only a spell of your specialized school in this slot. As with any other act, indulging in your sin might change your alignment if your behavior harms someone else." };
            yield return new TextBlock { Id = Guid.Parse("79fc4937-c4ec-4504-82a5-fbdc3e881308"), Type = TextBlockType.Text, Text = "__Add this additional spell slot manually__" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b437c667-2918-457f-ac7a-e126dfb3712b"), Feats.Instances.RunelordDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bd59a150-3cc3-4ad2-92cf-bbfe826d3c2f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
