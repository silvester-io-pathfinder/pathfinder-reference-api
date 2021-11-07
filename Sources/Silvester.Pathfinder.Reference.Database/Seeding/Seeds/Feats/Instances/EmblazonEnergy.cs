using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EmblazonEnergy : Template
    {
        public static readonly Guid ID = Guid.Parse("791ea55a-bb4d-4de9-b52c-1212ca9d7973");

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
            yield return new TextBlock { Id = Guid.Parse("f5a03893-725f-4713-aeb7-5508f4129f5a"), Type = TextBlockType.Text, Text = "With elemental forces, you make your emblazoned symbols more potent. When you (action: Emblazon an Armament | Emblazon Armament), you can choose from the following effects instead of the effects listed in that feat." };
            yield return new TextBlock { Id = Guid.Parse("4b2656e1-0d12-4ebd-947f-a8e2312e92da"), Type = TextBlockType.Text, Text = "These effects have the same restrictions as the base options." };
            yield return new TextBlock { Id = Guid.Parse("ec744099-67ef-43a7-be6f-7418c57db5d6"), Type = TextBlockType.Enumeration, Text = " Shield: Choose acid, cold, electricity, fire, or sonic. The wielder gain the shield’s circumstance bonus to saving throws against that damage type and can use Shield Block against damage of that type. The shield also gains resistance to that damage type equal to half your level if you have a domain spell with a trait matching that type (such as fire)." };
            yield return new TextBlock { Id = Guid.Parse("6ba70bc0-b074-4077-b491-46e4a150bb2f"), Type = TextBlockType.Enumeration, Text = " Weapon: Choose acid, cold, electricity, fire, or sonic. The weapon deals an extra 1d4 damage of that type. Increase this extra damage to 1d6 if you have a domain spell with a trait matching that type (such as fire)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0e6ecd7c-e7f1-4502-9b8a-15bcca42be12"), Feats.Instances.EmblazonArmament.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("da6bcff7-f554-4aa4-9d40-c7c51b0ef708"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
