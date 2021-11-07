using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElementalFamiliar : Template
    {
        public static readonly Guid ID = Guid.Parse("52c2d2e7-b796-4ce2-bba5-d053113af3eb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elemental Familiar",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ed48d156-4ac1-43e2-8316-9932421e556d"), Type = TextBlockType.Text, Text = "Your familiar becomes an elemental spirit capable of taking on aspects of the four elements: air, earth, fire, or water. Other than taking the form of an elemental instead of an animal, this familiar continues to use all the same rules as other familiars. Your familiar gains one additional familiar ability each day, which must be one of the following elemental familiar abilities. While your familiar has an elemental familiar ability, your familiar is composed of the associated elemental matter and gains the matching elemental trait. You can’t select more than one elemental familiar ability at a time." };
            yield return new TextBlock { Id = Guid.Parse("e7b2abd5-c94c-4b66-b4bc-85e9a6e710fd"), Type = TextBlockType.Enumeration, Text = " Air: If your familiar stays completely still for 1 round, it becomes invisible until it next takes an action. Any motion, even being moved or carried by another creature, ends this effect." };
            yield return new TextBlock { Id = Guid.Parse("a7babe5f-a8ba-4b30-8ff5-f788c1206ff0"), Type = TextBlockType.Enumeration, Text = " Earth: Your familiar gains resistance to physical damage (except adamantine) equal to half your level." };
            yield return new TextBlock { Id = Guid.Parse("dc9f0bcc-4882-4ca7-96e2-8c201316fa50"), Type = TextBlockType.Enumeration, Text = " Fire: Your familiar sheds bright light in a 20-foot radius (and dim light for the next 20 feet) and emits warmth. Creatures that remain within a 15-foot emanation don’t take damage from severe environmental cold." };
            yield return new TextBlock { Id = Guid.Parse("573a576f-3d33-41f4-a96e-15388ada2136"), Type = TextBlockType.Enumeration, Text = " Water: Your familiar can move through a gap at least 2 inches wide without Squeezing and can Squeeze through a gap at least 1 inch wide." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("22349d45-218d-4c3f-9403-7010c354f621"), Feats.Instances.ElementalDedication.ID);
            builder.HaveSpecificFeat(Guid.Parse("e046cc4f-0595-407b-8fb9-292aafc60295"), Feats.Instances.Familiar.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b799dd2b-59e6-4380-b434-134e4672d2e1"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
