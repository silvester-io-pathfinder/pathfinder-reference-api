using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationManualDexterity : Template
    {
        public static readonly Guid ID = Guid.Parse("b8776c34-6025-4ec7-b213-34bdd553c7a3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Manual Dexterity",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("678db53d-d19f-4cb1-9bb7-f961e1ffc4c5"), Type = TextBlockType.Text, Text = $"Your construct innovation has articulated hands or similar appendages with significant manual dexterity. It can perform {ToMarkdownLink<Models.Entities.Trait>("manipulate", Traits.Instances.Manipulate.ID)} actions with up to two of its limbs. As normal for a companion, it still can't wield weapons or held items that don't have the {ToMarkdownLink<Models.Entities.Trait>("companion", Traits.Instances.Companion.ID)} trait, and it can't activate items." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("79cf287e-94aa-4180-aeb9-15c4f8755b0b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
