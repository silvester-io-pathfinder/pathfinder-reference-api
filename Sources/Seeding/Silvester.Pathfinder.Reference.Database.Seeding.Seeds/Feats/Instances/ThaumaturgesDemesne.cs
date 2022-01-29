using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ThaumaturgesDemesne : Template
    {
        public static readonly Guid ID = Guid.Parse("85b09266-b400-4d26-84ab-1f4c9f905834");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Thaumaturge's Demesne",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3650ea51-52e5-4502-9d55-9b00ed30428a"), Type = TextBlockType.Text, Text = $"You have claimed an area or location as your demesne, granting you the ability to ward and protect it. When you select this feat, choose a demesne, an area of no more than 200 square feet. You must legitimately claim the area; in the case of a building or property, you must own it, and in the case of an unowned plot of land, no other inhabitants can contest your claim." };
            yield return new TextBlock { Id = Guid.Parse("47ceb879-eb4c-4360-a183-18be71bf303b"), Type = TextBlockType.Text, Text = $"Once you've chosen your demesne, it becomes automatically protected with an arcane {ToMarkdownLink<Models.Entities.Spell>("private sanctum", Spells.Instances.PrivateSanctum.ID)} spell with an unlimited duration, heightened to half your level rounded up and using your thaumaturge class DC in place of a spell DC, if necessary. Additionally, the demesne is attended by three unseen custodians, as called by a successful unseen custodian ritual (Advanced Player's Guide 245), and one object in the area gains an elemental sentinel, as a successful elemental sentinel ritual (Secrets of Magic 150)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5886721b-d47b-491d-bfe9-d0348735ef4a"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
