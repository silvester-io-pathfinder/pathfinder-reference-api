using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EmblazonEnergy : Template
    {
        public static readonly Guid ID = Guid.Parse("fcae1837-9bc3-4590-93c5-39a84dbe96b4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Emblazon Energy",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("88ddfc25-7373-45e8-a347-0adde37b7cb5"), Type = TextBlockType.Text, Text = $"With elemental forces, you make your emblazoned symbols more potent. When you {ToMarkdownLink<Models.Entities.Feat>("Emblazon an Armament", Feats.Instances.EmblazonArmament.ID)}, you can choose from the following effects instead of the effects listed in that feat." };
            yield return new TextBlock { Id = Guid.Parse("3faa108c-f974-42c2-8cf0-c3cdb88593d1"), Type = TextBlockType.Text, Text = $"These effects have the same restrictions as the base options." };
            yield return new TextBlock { Id = Guid.Parse("1f48feed-6e56-4331-8cdc-87b8aac8c83c"), Type = TextBlockType.Enumeration, Text = $" Shield: Choose acid, cold, electricity, fire, or sonic. The wielder gain the shield's circumstance bonus to saving throws against that damage type and can use Shield Block against damage of that type. The shield also gains resistance to that damage type equal to half your level if you have a domain spell with a trait matching that type (such as fire)." };
            yield return new TextBlock { Id = Guid.Parse("45d0619f-c762-4deb-9c6d-903b93c01792"), Type = TextBlockType.Enumeration, Text = $" Weapon: Choose acid, cold, electricity, fire, or sonic. The weapon deals an extra 1d4 damage of that type. Increase this extra damage to 1d6 if you have a domain spell with a trait matching that type (such as fire)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b01e1f0c-1ed6-4bb3-afb0-104ef57a2a1e"), Feats.Instances.EmblazonArmament.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c5cc6680-49d6-4070-b76b-5b07a3be63ed"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
