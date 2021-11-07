using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HobgoblinWeaponExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("d93ed0f1-fee3-4b8f-b5c7-08b207ec5318");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hobgoblin Weapon Expertise",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("07729203-e598-452a-8bf7-461feea1017b"), Type = TextBlockType.Text, Text = "You increase your training in battlefield weapons. Whenever you gain a class feature that grants you expert or greater proficiency in certain weapons, you also gain that proficiency rank in all weapons you are trained in from (Feat: Hobgoblin Weapon Familiarity)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4309b63e-f76d-4fce-ac0c-a303cbd87188"), Feats.Instances.HobgoblinWeaponFamiliarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("11bf5ba4-6f49-4c08-b621-44d9121961c1"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
