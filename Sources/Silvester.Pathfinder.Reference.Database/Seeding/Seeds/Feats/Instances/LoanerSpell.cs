using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LoanerSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("7898953b-b91f-46f2-a98d-77df104174b3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Loaner Spell",
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
            yield return new TextBlock { Id = Guid.Parse("31dccac5-18fb-41ff-9d71-276f127be00a"), Type = TextBlockType.Text, Text = "During your daily preparations, you can gain the assistance of an allied prepared spellcaster to prepare one spell for the day. The spell can be up to 3rd level. Your ally must be able to prepare and cast it, and the spell must have a Targets entry or an area. Your ally loses a spell slot of the corresponding spell level, and you gain the ability to cast the prepared spell once that day. When you (activity: Cast the Spell | Cast a Spell), use your class DC for any saving throws required by the spell, and your class DC – 10 as a spell attack roll modifier." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("58708d8b-d542-4fd7-a3db-0b32cc89731b"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("0f5556cf-7416-4d23-9c61-f2218c19e1e4"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("be83d0f1-5a03-408c-88f7-2303d2e3ec95"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("353acc47-d245-4f2a-8967-7806354a0be8"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("cd26a1d7-e448-48c4-965c-0f97dc4aa2e8"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
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
                Id = Guid.Parse("e69b40ce-ebeb-446f-a72d-29a8db1372dd"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
