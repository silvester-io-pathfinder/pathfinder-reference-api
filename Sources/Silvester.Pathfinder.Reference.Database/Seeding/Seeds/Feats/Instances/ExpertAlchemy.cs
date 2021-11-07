using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpertAlchemy : Template
    {
        public static readonly Guid ID = Guid.Parse("6e7a5cb4-b305-4bff-bc6b-412a2aec435b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expert Alchemy",
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
            yield return new TextBlock { Id = Guid.Parse("3b704b5d-ffcd-45c3-a986-0c98c6672f1e"), Type = TextBlockType.Text, Text = "Your advanced alchemy level increases to 3. At 10th level, it increases to 5." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("eba7da40-457a-42e7-bc3c-41b6844d95cf"), Feats.Instances.AlchemistDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("7b79d6b3-2698-420f-8553-1242a0cb885c"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c77adbfd-517d-4265-8101-5b5630945b7a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
