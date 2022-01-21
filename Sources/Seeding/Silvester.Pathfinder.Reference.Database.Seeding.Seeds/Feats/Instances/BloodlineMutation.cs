using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BloodlineMutation : Template
    {
        public static readonly Guid ID = Guid.Parse("60ae68f2-6a87-4f22-bbba-4d1f525d6e93");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bloodline Mutation",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("edb8a876-c237-4bdd-968c-151beb8dab9d"), Type = TextBlockType.Text, Text = $"You permanently mutate to become more like the creatures of your bloodline. You gain the appropriate trait or traits for those types of creatures (aberration for aberrant, angel and celestial for angelic, psychopomp and monitor for psychopomp, and so on). You gain low-light vision or darkvision, if one is appropriate for creatures with those traits. Choose one of the following." };
            yield return new TextBlock { Id = Guid.Parse("cc41c56b-6663-4857-b46b-385ed24edb4b"), Type = TextBlockType.Enumeration, Text = $" : If the creatures associated with your bloodline have the ability to fly, you gain a fly Speed equal to your land Speed." };
            yield return new TextBlock { Id = Guid.Parse("90c2c5dd-977c-4271-80c2-db23500dac0e"), Type = TextBlockType.Enumeration, Text = $" : If the creatures associated with your bloodline are aquatic or amphibious, you become amphibious, able to breathe water and air equally well, and you gain a swim Speed equal to your Speed." };
            yield return new TextBlock { Id = Guid.Parse("49c9e11b-3848-477d-9fa1-5d2edccb61d5"), Type = TextBlockType.Enumeration, Text = $" : If creatures associated with your bloodline have a resistance or immunity to acid, cold, electricity, fire, negative, or sonic, choose an energy type your bloodline is immune or resistant to and gain resistance 20 against that energy type." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("c835aedb-6fc5-4b91-8d5b-b54a87bc70d0"), "A bloodline that corresponds with a creature trait.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eeb8f0cc-104a-41d4-b266-36fb9ff34e49"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
