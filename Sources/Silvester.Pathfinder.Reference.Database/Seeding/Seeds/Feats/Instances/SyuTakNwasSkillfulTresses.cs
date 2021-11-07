using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SyuTakNwasSkillfulTresses : Template
    {
        public static readonly Guid ID = Guid.Parse("a17b5b65-7522-45ba-a91a-949c15ec9606");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Syu Tak-Nwa's Skillful Tresses",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f864290a-059d-49be-884c-e1a80df6cfc2"), Type = TextBlockType.Text, Text = "You can expertly control your living hair and use it to perform various tasks. You can perform simple (action: Interact) actions with your hair such as opening an unlocked door or picking up objects. Your hair can&#39;t perform actions that require fingers or significant manual dexterity, including any action that would require a check to accomplish. Your hair can hold items of up to 1 Bulk, but can&#39;t Activate or attack with any items it&#39;s holding." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("02aa2a30-eced-4f4b-a775-6b3209c33472"), Feats.Instances.LivingHair.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("de016ba7-4a89-4f58-81ac-d40e178d0a52"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
