using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UndeadCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("fa591a43-4ab1-42f2-9d6a-8e29047e981b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Undead Companion",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4c459354-3269-41ff-ab96-31185982c944"), Type = TextBlockType.Text, Text = "Your companion is also touched by undeath, a mix of a traditional companion and a skeleton, zombie, or stranger form of unlife. Your companion gains the (trait: undead) trait instead of the (trait: animal) trait and gains negative healing. It otherwise uses the normal rules for an animal companion or familiar; that means it can still be affected by many conditions or effects to which most undead are immune." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("1aae4b67-0983-4bc9-9e5c-56c644b94148"), or => 
            {
                or.HaveSpecificAnimalCompanionAmount(Guid.Parse("f9c0395d-abda-4456-b764-4585df2fa139"), Comparators.GreaterThanOrEqualTo, amount: 1);
                or.HaveAnyFamiliar(Guid.Parse("4d519607-7b30-46f3-b5cd-0aba3d143a12"));
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
                Id = Guid.Parse("1df6fb8a-7ba7-41b0-be8e-9bf74cba1167"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
