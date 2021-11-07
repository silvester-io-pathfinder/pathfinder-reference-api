using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuickIdentification : Template
    {
        public static readonly Guid ID = Guid.Parse("dad43787-ca93-431a-9d39-0374ac61ee92");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Identification",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bb3bf9f7-89ee-4b55-bde4-4f9590116aee"), Type = TextBlockType.Text, Text = "You can (action: Identify Magic) swiftly. You take only 1 minute when using (action: Identify Magic) to determine the properties of an item, ongoing effect, or location, rather than 10 minutes. If you’re a master, it takes a 3-action activity, and if you’re legendary, it takes 1 action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("b10a514c-7f68-4d5e-b15b-19e7255b43bf"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("c55ea651-3aa3-47b7-b0e3-aa97dea32dd5"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("4e152148-a265-424e-a92c-3b0aea43c3b4"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("7e01a88f-fbe2-48c5-aa59-d61ce0b68b5e"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("a04b25b5-acbc-4eea-986d-d078468e58cf"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c326d37e-1fb8-411e-ba02-cef0fe8ea775"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
