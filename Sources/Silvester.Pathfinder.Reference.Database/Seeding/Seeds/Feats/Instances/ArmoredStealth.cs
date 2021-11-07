using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArmoredStealth : Template
    {
        public static readonly Guid ID = Guid.Parse("7a83e60e-b90d-49d9-88fb-9061b57a4d2c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Armored Stealth",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d8cbe8d7-c6b2-4b9e-9d9e-2a7a5d7b43e3"), Type = TextBlockType.Text, Text = "You have learned techniques to adjust and modify your armor and movements to reduce the noise you make. When you wear non-(trait: noisy) armor with which you are trained, your penalty to Stealth checks is reduced by 1 (to a minimum penalty of 0). If you’re a master in Stealth, reduce the penalty by 2, and if you’re legendary, reduce the penalty by 3. If your armor has the (trait: noisy) trait, instead of reducing the penalty to Stealth checks, you ignore the effects of the (trait: noisy) trait, enabling you to remove the penalty with a sufficient Strength score as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("ca1ac8dc-ca04-4220-b1d6-d570954f907d"), Proficiencies.Instances.Expert.ID, Skills.Instances.Stealth.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("caac2a27-56e7-4be5-b09d-67cf4fd18410"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
