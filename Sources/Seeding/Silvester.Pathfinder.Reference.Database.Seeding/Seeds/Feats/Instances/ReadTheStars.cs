using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReadTheStars : Template
    {
        public static readonly Guid ID = Guid.Parse("a159751c-726d-4b7e-8eb6-33afb0df982a");

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
            yield return new TextBlock { Id = Guid.Parse("a0836afb-5b35-4a2f-b747-2c62bbfba84a"), Type = TextBlockType.Text, Text = "You're incredibly skilled in iruxi astrology, and you can gain useful (if cryptic) hints from the stars' alignment. Once per night, if you can clearly see the stars, you can spend 1 hour reading the heavens to see how they relate to a particular goal, event, or activity that will occur within 1 week. The GM rolls a secret check, either a DC 28 Astrology Lore check or a DC 32 Occultism check. On a success, you learn a cryptic clue or piece of advice that could help with the chosen event, and on a critical failure, you learn a misleading cryptic clue or piece of advice." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("10a8111f-7884-4384-8034-8282523eea77"), or => 
            {
                or.HaveSpecificLoreSpecificProficiency(Guid.Parse("24c7c0e7-7454-4c05-9c56-102a5520bcb3"), Proficiencies.Instances.Trained.ID, Lores.Instances.Astrology.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("606154b3-f3d4-4653-9283-78dee099e4e8"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
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
                Id = Guid.Parse("1737df55-e47a-4912-a7ff-71f22087b1d2"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
