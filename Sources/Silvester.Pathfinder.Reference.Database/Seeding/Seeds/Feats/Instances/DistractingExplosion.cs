using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DistractingExplosion : Template
    {
        public static readonly Guid ID = Guid.Parse("ae5becc9-ad77-4a5c-8994-9e35e0a3221b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Distracting Explosion",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If your innovation is a minion, it can take this reaction instead of you, even though minions can't normally take reactions or act when it's not their turn. It uses your reaction for the turn to do so.",
                Trigger = "A creature within your reach uses a concentrate action.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5f1835e7-5d05-4ac5-b199-47f1086b369e"), Type = TextBlockType.Text, Text = "Your enemies think they can concentrate on something else while you’re nearby? Oh, you’ll give them a distraction, all right! Make a melee (action: Strike) against the triggering creature with a weapon or unarmed attack that is benefiting from your offensive boost. This (action: Strike) doesn’t count toward your multiple attack penalty, and your multiple attack penalty doesn’t apply to this (action: Strike)." };
            yield return new TextBlock { Id = Guid.Parse("a7be5c09-9601-4766-9ebd-62293cdbbc03"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("d33d9f97-181b-472f-81b4-5d27e935a5a1"), Type = TextBlockType.Text, Text = "~ Unstable Function: You pull out all the stops to create an explosive distraction. Add the (trait: unstable) trait to Distracting Explosion. If the attack hits, you disrupt the triggering (trait: concentrate) action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("e9dcf98b-4fc7-434f-8217-1fe91a37b935"), ClassFeatures.Gunslingers.OffensiveBoost.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("daf5206b-b1ff-4705-bcef-da7ce2dabff7"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
