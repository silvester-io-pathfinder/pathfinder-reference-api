using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuickRecognition : Template
    {
        public static readonly Guid ID = Guid.Parse("d43b3151-7fd6-4499-a96c-f66e2f9766c2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Recognition",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7ce3d7d6-6861-4b79-81db-5b53e0088082"), Type = TextBlockType.Text, Text = "You (action: Recognize Spells | Recognize Spell) swiftly. Once per round, you can (action: Recognize a Spell | Recognize Spell) using a skill in which you're a master as a free action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("22455f21-17c8-4253-8486-487766a81719"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("fe49d8b9-376d-403f-9877-cac25c4334de"), Proficiencies.Instances.Expert.ID, Skills.Instances.Arcana.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("c1491855-bf4a-46eb-af2c-5b6c1b9dc782"), Proficiencies.Instances.Expert.ID, Skills.Instances.Nature.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("489a8d62-3713-405f-b3ae-1ec173b411c8"), Proficiencies.Instances.Expert.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("da1ae0de-8194-41c0-bc26-793126f652e4"), Proficiencies.Instances.Expert.ID, Skills.Instances.Religion.ID);
            });
            builder.HaveSpecificFeat(Guid.Parse("4118f309-287e-432c-8043-30f770d3f45c"), Feats.Instances.RecognizeSpell.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("59a34a46-479f-422b-8212-4cefdae76007"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
