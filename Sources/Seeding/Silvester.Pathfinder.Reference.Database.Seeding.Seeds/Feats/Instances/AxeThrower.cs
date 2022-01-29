using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AxeThrower : Template
    {
        public static readonly Guid ID = Guid.Parse("e6f865da-f74f-41b0-ab44-ebd8f2875dd2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Axe Thrower",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3e194a5b-646e-470f-a76f-351cb7b91c35"), Type = TextBlockType.Text, Text = $"You have mastered the weight and balance of a variety of axes and can lob them with ease. Any one-handed axe weapon you wield has the {ToMarkdownLink<Models.Entities.Trait>("thrown", Traits.Instances.Thrown.ID)} trait with a range of 10 feet. For axes that already have the {ToMarkdownLink<Models.Entities.Trait>("thrown", Traits.Instances.Thrown.ID)} trait, the range increases by 10 feet. When you critically succeed at an attack roll with a thrown axe weapon, you apply the axe's critical specialization effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0f67b119-9aaa-4ae8-b8de-a5ab2f54a38e"), Feats.Instances.TurpinRoweLumberjackDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e2e6af6e-8505-4465-849f-d3f488b55122"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
