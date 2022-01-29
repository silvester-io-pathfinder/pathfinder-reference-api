using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReplenishmentOfWar : Template
    {
        public static readonly Guid ID = Guid.Parse("dc2af4fa-8d10-42e6-b9b9-27c4a097aad0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Replenishment of War",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("307016ef-23b1-426a-b0db-e7e5d23eadd1"), Type = TextBlockType.Text, Text = $"Striking out against your enemies draws praise and protection from your deity. When you damage a creature with a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} using your deity's favored weapon, you gain a number of temporary Hit Points equal to half your level, or equal to your level if the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} was a critical hit. These temporary Hit Points last until the start of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveFavoredWeaponSpecificProficiency(Guid.Parse("90bce786-79da-41b1-a137-c61b41c42e9e"), Proficiencies.Instances.Expert.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dd1a53a2-ec96-4349-976e-af6ad85f7a98"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
