using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RitesOfConvocation : Template
    {
        public static readonly Guid ID = Guid.Parse("133379f7-e436-4aff-817c-93c4db6c09b0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rites of Convocation",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6bfd8396-9ddf-4828-94a2-a41652ec0c8c"), Type = TextBlockType.Text, Text = $"Your patron grants you the power to summon other creatures to aid you. Choose one summon spell (such as {ToMarkdownLink<Models.Entities.Spell>("summon animal", Spells.Instances.SummonAnimal.ID)}, {ToMarkdownLink<Models.Entities.Spell>("summon construct", Spells.Instances.SummonConstruct.ID)}, and so forth) that appears on the spell list of your spellcasting tradition. You can spend 10 minutes in communion with your familiar to replace one spell you've prepared in one of your witch spell slots with the spell you chose, heightened to the same level. The spell you replaced must be of at least the summon spell's minimum spell level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("89e394c8-ef9b-4fe9-9d41-658e0650e37a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
