using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MantraOfDiscipline : Template
    {
        public static readonly Guid ID = Guid.Parse("de090455-14ca-4037-879c-5b7c85b4c55e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mantra of Discipline",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("69b8b5e6-4b37-4fc5-bc41-a4976c61b8d6"), Type = TextBlockType.Text, Text = "You mentally or audibly utter a word or phrase that gives you the mettle to see through tricks and endure pain. Your mantra grants you a +1 status bonus to saving throws against (trait: illusion) and (trait: enchantment) effects until the start of your next turn. You also gain this bonus against any effect that works primarily by causing pain (even if it isn’t an (trait: illusion) or (trait: enchantment) effect), as well as resistance equal to half your level against damage caused by such an effect. These effects must work primarily by inflicting pain, such as (spell: phantom pain) or (spell: savor the sting), rather than simply causing injury; the GM is the final arbiter of what counts as such an effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            //TODO: Add prerequisites.
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("535322e7-b99a-47ce-b3bf-7aa22cf37f23"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
