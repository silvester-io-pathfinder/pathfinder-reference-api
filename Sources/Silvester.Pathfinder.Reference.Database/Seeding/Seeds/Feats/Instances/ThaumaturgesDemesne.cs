using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ThaumaturgesDemesne : Template
    {
        public static readonly Guid ID = Guid.Parse("ac10ef7d-8d94-40fc-8eba-594b25bdead7");

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
            yield return new TextBlock { Id = Guid.Parse("8a4d185c-1286-4672-9437-0a7d6db11dc1"), Type = TextBlockType.Text, Text = "You have claimed an area or location as your demesne, granting you the ability to ward and protect it. When you select this feat, choose a demesne, an area of no more than 200 square feet. You must legitimately claim the area; in the case of a building or property, you must own it, and in the case of an unowned plot of land, no other inhabitants can contest your claim." };
            yield return new TextBlock { Id = Guid.Parse("eee88186-e048-4f06-8ba2-5e816ea8e363"), Type = TextBlockType.Text, Text = "Once you’ve chosen your demesne, it becomes automatically protected with an arcane (spell: private sanctum) spell with an unlimited duration, heightened to half your level rounded up and using your thaumaturge class DC in place of a spell DC, if necessary. Additionally, the demesne is attended by three unseen custodians, as called by a successful unseen custodian ritual (Advanced Player’s Guide 245), and one object in the area gains an elemental sentinel, as a successful elemental sentinel ritual (Secrets of Magic 150)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e17c739e-0d10-4dd9-a422-6a9b9a7bbe89"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
