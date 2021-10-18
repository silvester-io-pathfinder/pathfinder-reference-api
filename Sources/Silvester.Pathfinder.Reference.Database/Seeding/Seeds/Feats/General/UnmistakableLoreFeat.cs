using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class UnmistakableLoreFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("eb5ca078-b3f2-4e84-8df4-526ced138637");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unmistakable Lore",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("95e082e4-1262-4fa5-8937-a0bf794053eb"), Type = Utilities.Text.TextBlockType.Text, Text = "You never get information about your areas of expertise wrong. When you Recall Knowledge using any Lore subcategory in which you’re trained, if you roll a critical failure, you get a failure instead. If you’re a master in a Lore subcategory, on a critical success, you gain even more information or context than usual." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new HaveAnyLoreProficiencyPrerequisite { Id = Guid.Parse("121e5838-bd62-46a7-a282-3e096dd7d271"), RequiredProficiencyId = Proficiencies.Instances.Expert.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("912aae48-2683-49d1-bd6e-20a228871dce"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 268
            };
        }
    }
}
