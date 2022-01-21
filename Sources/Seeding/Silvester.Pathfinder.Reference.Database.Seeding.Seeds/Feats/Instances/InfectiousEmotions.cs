using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InfectiousEmotions : Template
    {
        public static readonly Guid ID = Guid.Parse("2d688517-fe5d-4dde-a5b4-e9834f66adca");

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
            yield return new TextBlock { Id = Guid.Parse("f5a3b926-0c95-4a1d-8ba8-dbfdcbe31047"), Type = TextBlockType.Text, Text = "When you use (feat: Catharsis), one ally within 30 feet gains the catharsis activation benefits in addition to you. If these benefits require an (feat: emotional focus), they use your (feat: emotional focus) as they're experiencing an empathic imprint of your emotions. Depending on the activation benefit, it might be impossible to grant it to an ally; for instance, (feat: pride) could only have an effect for an ally if both you and the ally critically failed the same saving throw against the same effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3a81b1b8-5003-4f61-bfe9-b8964f455e57"), Feats.Instances.CatharticMageDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6bfd0857-c333-40fa-8814-6d15d01a9e78"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}