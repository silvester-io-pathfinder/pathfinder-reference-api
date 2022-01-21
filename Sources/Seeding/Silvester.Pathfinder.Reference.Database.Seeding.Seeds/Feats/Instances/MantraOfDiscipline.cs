using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MantraOfDiscipline : Template
    {
        public static readonly Guid ID = Guid.Parse("17b3c475-6ace-4b8b-9600-0d843dff6b11");

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
            yield return new TextBlock { Id = Guid.Parse("a39dc352-2e91-42d0-baa0-d4756cead4d1"), Type = TextBlockType.Text, Text = "You mentally or audibly utter a word or phrase that gives you the mettle to see through tricks and endure pain. Your mantra grants you a +1 status bonus to saving throws against (trait: illusion) and (trait: enchantment) effects until the start of your next turn. You also gain this bonus against any effect that works primarily by causing pain (even if it isn't an (trait: illusion) or (trait: enchantment) effect), as well as resistance equal to half your level against damage caused by such an effect. These effects must work primarily by inflicting pain, such as (spell: phantom pain) or (spell: savor the sting), rather than simply causing injury; the GM is the final arbiter of what counts as such an effect." };
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
                Id = Guid.Parse("64e69b1f-3be0-46e6-beb1-1031e6ca54f9"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
