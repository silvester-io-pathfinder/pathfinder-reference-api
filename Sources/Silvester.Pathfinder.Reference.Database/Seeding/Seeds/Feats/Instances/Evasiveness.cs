using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Evasiveness : Template
    {
        public static readonly Guid ID = Guid.Parse("86ef1a15-9914-4362-be56-b60adc43479d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Evasiveness",
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
            yield return new TextBlock { Id = Guid.Parse("123b7f64-7358-42c7-b1aa-1f75fc29b213"), Type = TextBlockType.Text, Text = "Your proficiency rank for Reflex saves increases to master." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cfa4bffb-d5c7-42ac-b6cc-d1900f4a9cb4"), Feats.Instances.SwashbucklerDedication.ID);
            builder.HaveSpecificSavingThrowSpecificProficiency(Guid.Parse("b43aa430-cf02-4787-bfcf-f66c4e9725ed"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Reflex.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5086ec0d-fdbd-49ea-ba65-ee9a1f2acb89"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
