using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HellsArmaments : Template
    {
        public static readonly Guid ID = Guid.Parse("f3df1bc4-8451-476f-863e-5e3daf21e1c9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hell's Armaments",
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
            yield return new TextBlock { Id = Guid.Parse("6a42a770-d651-405a-a56a-8091e12d66c2"), Type = TextBlockType.Text, Text = "You’ve trained with your order’s weapon and your Hellknight plate long enough to apply your expertise from other weapons and armor. If you have expert proficiency in any weapon or unarmed attack, you gain expert proficiency in your order’s weapon as well. If you have expert proficiency in any armor or unarmored defense, you gain expert proficiency in Hellknight plate as well." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3593dafc-0205-4c87-a9e6-59137ff2e239"), Feats.Instances.HellknightDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("83c361b5-0f13-4e4b-9ac8-fd0d8b0d2e15"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
