using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BloodlineMutation : Template
    {
        public static readonly Guid ID = Guid.Parse("cdd16385-d8c4-44aa-8f3b-f66b48bddc6b");

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
            yield return new TextBlock { Id = Guid.Parse("58db6ad6-2da0-4f4b-b814-9d8b92a8c66d"), Type = TextBlockType.Text, Text = "You permanently mutate to become more like the creatures of your bloodline. You gain the appropriate trait or traits for those types of creatures (aberration for aberrant, angel and celestial for angelic, psychopomp and monitor for psychopomp, and so on). You gain low-light vision or darkvision, if one is appropriate for creatures with those traits. Choose one of the following." };
            yield return new TextBlock { Id = Guid.Parse("96273ea6-5eef-4290-990e-7b3ae7f7746d"), Type = TextBlockType.Enumeration, Text = " : If the creatures associated with your bloodline have the ability to fly, you gain a fly Speed equal to your land Speed." };
            yield return new TextBlock { Id = Guid.Parse("3765443d-c6e7-4ba7-bdbb-af1122b5ae30"), Type = TextBlockType.Enumeration, Text = " : If the creatures associated with your bloodline are aquatic or amphibious, you become amphibious, able to breathe water and air equally well, and you gain a swim Speed equal to your Speed." };
            yield return new TextBlock { Id = Guid.Parse("0ce60657-4574-4294-b4ae-d648707005ca"), Type = TextBlockType.Enumeration, Text = " : If creatures associated with your bloodline have a resistance or immunity to acid, cold, electricity, fire, negative, or sonic, choose an energy type your bloodline is immune or resistant to and gain resistance 20 against that energy type." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("30c193f6-25e3-4472-a88e-9487068db75e"), "A bloodline that corresponds with a creature trait.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f25f2fb6-a517-45c3-8f68-6174b1b002ce"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
