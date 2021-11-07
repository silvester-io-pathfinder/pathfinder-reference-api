using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LivingMonolithDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("b0947f55-7876-4ce0-a25f-51a8a2b2a7d0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Living Monolith Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the living monolith archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("68ec25d5-4f61-4581-8d00-992b63b64b68"), Type = TextBlockType.Text, Text = "~ Access: You are from the Golden Road region." };
            yield return new TextBlock { Id = Guid.Parse("5c61b584-648a-46ec-be09-d5bb97dc8eaa"), Type = TextBlockType.Text, Text = "You’ve begun to inscribe a magical stone called a ka stone that you will someday tie to your soul. You gain knowledge of Ancient Osirion and a connection to your nascent ka stone. If you fail a recovery check while dying, your dying condition does not increase; if you critically fail, your dying condition increases by only 1. You become trained in Ancient Osirion Lore, or expert if you were already trained." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("214f08c9-929c-4cfb-919c-332c1e8c3809"), Feats.Instances.AncientOsiriani.ID);
            builder.HaveSpecificLanguage(Guid.Parse("15abbacb-c116-4919-a952-1138bdb78dd6"), Languages.Instances.Sphinx.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("746816a4-0bab-4dca-ba72-b86c1ab5578c"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("959d6fb0-7c8c-4cc5-ba1e-27c280bc0871"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
