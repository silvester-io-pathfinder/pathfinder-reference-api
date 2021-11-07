using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HeavensThunder : Template
    {
        public static readonly Guid ID = Guid.Parse("b4606899-2039-4a8a-8365-00fb42d15f3c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Heaven's Thunder",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("aeddfb38-39b5-4f3b-a3ff-c4896b153e71"), Type = TextBlockType.Text, Text = "With a loud shout, you unleash your ki in a crackling shroud of thunder and lightning that engulfs your body. Until the end of your next turn, your unarmed attacks and weapons you wield that have the (trait: monk | Monk - Item) trait deal additional electricity damage equal to one-half your level and additional sonic damage equal to one-half your level." };
            yield return new TextBlock { Id = Guid.Parse("96a7336b-c554-4117-a830-4ff51389899d"), Type = TextBlockType.Text, Text = "If you also know the (spell: ki blast) ki spell, you can choose to deal either electricity or sonic damage with the spell instead of force while this effect is active ((spell: ki blast) loses the (trait: force) trait and gains the (trait: electricity) or (trait: sonic) trait instead). Any creature who successfully (action: Grapples | Grapple) you or is successfully (action: Grappled | Grapple) by you also takes this damage immediately after the (action: Grapple) check is resolved." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f08ddef8-cdd7-4ee5-a03e-f5cc45acbe11"), Feats.Instances.JalmeriHeavenseekerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bb2b39c8-55da-4aa0-8ef8-ca95b5e7e3f3"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
