using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VersatileFont : Template
    {
        public static readonly Guid ID = Guid.Parse("459e640a-fbf4-4dd6-9132-f7a78199e743");

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
            yield return new TextBlock { Id = Guid.Parse("6b2574ed-9189-488c-8ac4-65804fe455b8"), Type = TextBlockType.Text, Text = $"As you explore your deity's aspects, you move beyond restrictions on healing or harming. You can prepare either {ToMarkdownLink<Models.Entities.Spell>("harm", Spells.Instances.Harm.ID)} or {ToMarkdownLink<Models.Entities.Spell>("heal", Spells.Instances.Heal.ID)} in the spell slots gained from the harmful font or healing font." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("af069278-10d2-4448-b906-2377038e2c63"), or => 
            {
                or.HaveSpecificDivineFont(Guid.Parse("91890fbc-8b32-4347-b0f1-fc6d11167889"), DivineFonts.Instances.Harm.ID);
                or.HaveSpecificDivineFont(Guid.Parse("015db684-dbf0-4ca7-a4dc-5f7dbe76cda1"), DivineFonts.Instances.Heal.ID);
            });
            builder.HaveAnyDeitySpecificFont(Guid.Parse("728ceb92-1716-4575-9faa-d451abe89cff"), DivineFonts.Instances.Harm.ID);
            builder.HaveAnyDeitySpecificFont(Guid.Parse("baa78234-96b7-441e-9cd0-ef59b26af404"), DivineFonts.Instances.Heal.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1fcc1f70-2a37-4328-ac45-5c5ffb1017c8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
