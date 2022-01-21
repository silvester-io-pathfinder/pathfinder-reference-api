using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationMarvelousGears : Template
    {
        public static readonly Guid ID = Guid.Parse("c613caf4-3a06-479b-9203-d784f3c525ed");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Marvelous Gears",
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
            yield return new TextBlock { Id = Guid.Parse("012d5a32-a808-43b8-937a-3599bea91632"), Type = TextBlockType.Text, Text = "Your innovation gains expert proficiency in Intimidation, Stealth, and Survival. For any of these skills in which it was already an expert (because of being an advanced construct companion, for example), it gains master proficiency instead. If you have the revolutionary innovation class feature, these proficiencies improve to master, or legendary if your construct innovation was already an expert. You must have the (feat: wonder gears | Modification - Wonder Gears) modification to select this modification." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("af362448-bc8d-4d76-b443-9beb690a14fe"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
