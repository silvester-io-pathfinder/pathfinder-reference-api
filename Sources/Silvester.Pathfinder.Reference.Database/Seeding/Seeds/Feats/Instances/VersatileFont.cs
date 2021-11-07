using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VersatileFont : Template
    {
        public static readonly Guid ID = Guid.Parse("b8751700-bb75-4d0b-8149-57c2024c9dd7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Versatile Font",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("32ae96b9-3b83-4671-8f02-0239e62abe16"), Type = TextBlockType.Text, Text = "As you explore your deity’s aspects, you move beyond restrictions on healing or harming. You can prepare either (spell: harm) or (spell: heal) in the spell slots gained from the harmful font or healing font." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("f268f8b1-9396-456a-a777-4bf773e4f7ce"), or => 
            {
                or.HaveSpecificDivineFont(Guid.Parse("7e984078-2b68-4ed9-a056-1c0d92727ea0"), DivineFonts.Instances.Harm.ID);
                or.HaveSpecificDivineFont(Guid.Parse("c78896bd-cf7c-4998-95a6-b8b096ab27c1"), DivineFonts.Instances.Heal.ID);
            });
            builder.HaveAnyDeitySpecificFont(Guid.Parse("9a1c2d6c-5065-462c-986a-e11ceaa6f0ca"), DivineFonts.Instances.Harm.ID);
            builder.HaveAnyDeitySpecificFont(Guid.Parse("d9642658-8b11-478f-8a87-cc5ddd22073b"), DivineFonts.Instances.Heal.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a70ebb99-4a58-409b-80fc-7570126b3a39"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
