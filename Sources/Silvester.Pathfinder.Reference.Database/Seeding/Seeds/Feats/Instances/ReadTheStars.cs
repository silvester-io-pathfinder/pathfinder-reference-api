using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReadTheStars : Template
    {
        public static readonly Guid ID = Guid.Parse("368a760e-fcab-4ee2-a44f-33cacb34aa08");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Read the Stars",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c610da79-f9ee-4c6c-bc73-7c9e9f8e3bb6"), Type = TextBlockType.Text, Text = "You’re incredibly skilled in iruxi astrology, and you can gain useful (if cryptic) hints from the stars’ alignment. Once per night, if you can clearly see the stars, you can spend 1 hour reading the heavens to see how they relate to a particular goal, event, or activity that will occur within 1 week. The GM rolls a secret check, either a DC 28 Astrology Lore check or a DC 32 Occultism check. On a success, you learn a cryptic clue or piece of advice that could help with the chosen event, and on a critical failure, you learn a misleading cryptic clue or piece of advice." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("3bb4104c-8fb0-4f47-a9aa-76d04dccb4f8"), or => 
            {
                or.HaveSpecificLoreSpecificProficiency(Guid.Parse("bf31d4ad-3c52-4515-870a-885cd39fd686"), Proficiencies.Instances.Trained.ID, Lores.Instances.AStrology.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("85ec5595-19c7-4249-b571-932020e51280"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
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
                Id = Guid.Parse("36294368-9f9d-4a52-bbe1-e1d61288ed7d"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
