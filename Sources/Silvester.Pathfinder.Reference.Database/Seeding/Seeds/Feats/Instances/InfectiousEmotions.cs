using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InfectiousEmotions : Template
    {
        public static readonly Guid ID = Guid.Parse("55b59f3d-0e88-4382-af9a-ab513031149e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Infectious Emotions",
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
            yield return new TextBlock { Id = Guid.Parse("a0404f55-c60c-45f8-8ff1-a89d603646f4"), Type = TextBlockType.Text, Text = "When you use (feat: Catharsis), one ally within 30 feet gains the catharsis activation benefits in addition to you. If these benefits require an (feat: emotional focus), they use your (feat: emotional focus) as they’re experiencing an empathic imprint of your emotions. Depending on the activation benefit, it might be impossible to grant it to an ally; for instance, (feat: pride) could only have an effect for an ally if both you and the ally critically failed the same saving throw against the same effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("13fe30b2-1173-4fe6-8618-e92da97bc3b1"), Feats.Instances.CatharticMageDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7f3c860b-012b-41d4-866d-63205d82f016"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
