using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FiendishLore : Template
    {
        public static readonly Guid ID = Guid.Parse("64c18ea8-2fa6-48f4-92e7-55a13a9db2f2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fiendish Lore",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b0143b9d-26a1-4a8d-8c6a-6ba4e04e0f5b"), Type = TextBlockType.Text, Text = "You were raised by a tiefling or a fiendish relative, or you&#39;ve devoted yourself to researching the secrets of the fiendish realms. You gain the trained proficiency rank in Intimidation and Religion. If you would automatically become trained in one of those skills (from your background or class, for example), you instead become trained in a skill of your choice. You also become trained in a Lore skill related to the fiendish plane from which you trace your lineage (usually Abaddon Lore, Abyss Lore, or Hell Lore)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("02706047-77bb-49b5-8e3e-cbdb3d373669"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
