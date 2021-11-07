using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AttunedStride : Template
    {
        public static readonly Guid ID = Guid.Parse("9b4abba5-7562-4234-a3f0-51bbe71d23a6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Attuned Stride",
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
            yield return new TextBlock { Id = Guid.Parse("31117bb4-0892-4162-a015-4b49fd754112"), Type = TextBlockType.Text, Text = "You can move freely through terrain you’re attuned to. When you gain a terrain attunement benefit, you ignore difficult terrain in the corresponding type of terrain until the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("845d8b7f-3fe1-4fac-9b7e-4cc392570f05"), Feats.Instances.GeomancerDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("13af10c9-6d6b-49fd-9c12-b140535754d7"), Proficiencies.Instances.Expert.ID, Skills.Instances.Nature.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a638ac8-099f-4d5b-8e70-98b810868493"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
